# 导入os和sys模块
import os
import sys

# 定义要替换的字符串
old_str = "Starter"
# 获取命令行传入的字符串
new_str = sys.argv[1]

# 遍历当前目录及其子目录下的所有文件和文件夹
for root, dirs, files in os.walk("."):
    # 遍历当前目录下的所有文件
    for file in files:
        # 获取文件的完整路径
        file_path = os.path.join(root, file)
        # 如果文件名中包含要替换的字符串
        if old_str in file:
            # 读取文件内容
            with open(file_path, "r", encoding="utf-8") as f:
                content = f.read()
            # 将文件内容中的要替换的字符串替换成新的字符串
            content = content.replace(old_str, new_str)
            # 写回文件
            with open(file_path, "w", encoding="utf-8") as f:
                f.write(content)
            # 重命名文件，将文件名中的要替换的字符串替换成新的字符串
            new_name = file.replace(old_str, new_str)
            new_path = os.path.join(root, new_name)
            os.rename(file_path, new_path)
    # 遍历当前目录下的所有文件夹
    for dir in dirs:
        # 获取文件夹的完整路径
        dir_path = os.path.join(root, dir)
        # 如果文件夹名中包含要替换的字符串
        if old_str in dir:
            # 重命名文件夹，将文件夹名中的要替换的字符串替换成新的字符串
            new_name = dir.replace(old_str, new_str)
            new_path = os.path.join(root, new_name)
            os.rename(dir_path, new_path)
