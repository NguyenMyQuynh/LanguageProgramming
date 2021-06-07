#!/bin/sh

echo "Nhap ten: "
read ten
echo "Nhap MSSV: "
read mssv

#Bao gom truong hop nguoi dung chi Enter
while [ "$mssv" != "19520241" ]; do 
	echo "Nhap lai MSSV: "
	read mssv
done
echo "Xin chao $mssv"

exit 0 
