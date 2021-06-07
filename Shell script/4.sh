#!/bin/sh

file="./test.txt"
echo "Nhap mot chuoi: "
read chuoi
if grep -q $chuoi $file; then
	echo "Chuoi co ton tai"
else 
	echo "Chuoi khong ton tai"
fi
exit 0
