import sys
import random

if len(sys.argv) < 2:
    print("Usage: python3 generate.py maxNum [random]")
    sys.exit(1)

try:
    arg1 = int(sys.argv[1])
except ValueError:
    print("Error: maxNum must be an integer")
    sys.exit(1)

maxNum = arg1
with open(f"data{maxNum}.txt", "w") as f_data, open(f"data{maxNum}_ref", "w") as f_ref:
    if len(sys.argv) == 3 and sys.argv[2] == "random":
        for i in range(1, maxNum + 1):
            rand_num = random.randint(0, maxNum)
            f_data.write(str(rand_num) + "\n")
            f_ref.write(str(rand_num) + ";")
    else:
        for i in range(1, maxNum + 1):
            f_data.write(str(i) + "\n")
            f_ref.write(str(i) + ";")
