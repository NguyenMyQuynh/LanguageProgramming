.section .data
	msg: .string "Helloworl" # Khai bao chuoi
	len = . -msg # lay do dai chuoi

.section .bss
	.lcomm output, 1 # khai bao o nho de xuat output

.section .text
	.globl _start

_start:

	mov $len, %eax # chuyen do dai chuoi vao eax
	addl $47, %eax # cong eax cho 47 (vi eax - 1 + 48)
	mov %al, (output) # chuyen gia tri eax vao vung nho output de xuat

	movl $4, %eax
	movl $1, %ebx
	movl $output, %ecx
	movl $1, %edx
	int $0x80 # xuat gia tri

	movl $1, %eax
	movl $0, %ebx
	int $0x80 # ket thuc chuong trinh
