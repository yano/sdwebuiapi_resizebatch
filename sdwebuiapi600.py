import sys
import subprocess

# 1240 -> 600

# テキストファイルのパスを指定
#file_path = 'dir_list.txt'  # ファイルパスを適切に変更してください
args = args = sys.argv # ディレクトリパスのテキストリストを引数で指定しておく
file_path = args[1]

# ファイルを読み込んで各行をリストに格納する関数
def read_file_and_store_lines(file_path):
    try:
        with open(file_path, 'r', encoding='utf-8') as file:
            lines = file.readlines()
        return lines
    except FileNotFoundError:
        print(f"指定されたファイル '{file_path}' は見つかりませんでした。")
        return None
    except Exception as e:
        print(f"エラーが発生しました: {e}")
        return None

# テキストファイルの各行をリストに格納
lines_list = read_file_and_store_lines(file_path)

script_path = 'sdwebuiapi_internal.py'

# リストの内容を表示
if lines_list is not None:
    print("テキストファイルの各行:")
    for line in lines_list:
        print(line.strip())  # 各行から改行文字を取り除いて表示
        #sdwebuiapi_test(line.strip())
        arg1 = line.strip()
        arg2 = '600'
        subprocess.run(['python', script_path, arg1, arg2])
        print('end')
