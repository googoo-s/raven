# 导入os和sys模块
import os
import sys

# 定义要替换的字符串
old_str = "Starter"
# 获取命令行传入的字符串
new_str = sys.argv[1]

# 遍历当前目录下的所有文件和文件夹
for item in os.listdir("."):
    # 如果是文件，并且文件名中包含要替换的字符串
    if os.path.isfile(item) and old_str in item:
        # 读取文件内容
        with open(item, "r", encoding="utf-8") as f:
            content = f.read()
        # 将文件内容中的要替换的字符串替换成新的字符串
        content = content.replace(old_str, new_str)
        # 写回文件
        with open(item, "w", encoding="utf-8") as f:
            f.write(content)
        # 重命名文件，将文件名中的要替换的字符串替换成新的字符串
        new_name = item.replace(old_str, new_str)
        os.rename(item, new_name)
