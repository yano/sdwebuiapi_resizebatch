import sys
import os
import glob
import webuiapi
from PIL import Image, ImageDraw


# 引数に画像処理対象となるpngファイルが入っているフォルダのパスを指定する
args = args = sys.argv
path_dir = args[1]

# create API client
api = webuiapi.WebUIApi(host='127.0.0.1', port=7860)

# https://github.com/AUTOMATIC1111/stable-diffusion-webui-rembg
rembg = webuiapi.RemBGInterface(api)

path_list = glob.glob(path_dir + '/*.png')
#print(path_dir)
print(len(path_list))

for path in path_list:
    imageTmp = Image.open(path)
    result1 = api.extra_single_image(image=imageTmp, resize_mode=1, upscaler_1=webuiapi.Upscaler.ESRGAN_4x, upscaling_resize=1, upscaling_resize_w=600, upscaling_resize_h=600)
    result2 = rembg.rembg(input_image=result1.image, model='isnet-anime', return_mask=False)
    base_dir_pair = os.path.split(path)

    dst_dir = base_dir_pair[0] + '/Resize600AndRembg'

    # ディレクトリが存在しない場合、ディレクトリを作成する
    if not os.path.exists(dst_dir):
        os.makedirs(dst_dir)

    result2.image.save(dst_dir + '/'  + base_dir_pair[1], "PNG")
