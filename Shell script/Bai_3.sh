#!/bin/sh

echo "Nhap n: "
read n

while [ $n -lt 10 ]; do 
	echo "Nhap n>=10 :"
	read n
done
i=0 #count 
s=0 #sum
while [ $i -lt $n ]; do 
	i=$(($i+1))
	s=$(($s+$i))
done
echo "Tong cac so tu 1 den $n la: $s"
exit 0
