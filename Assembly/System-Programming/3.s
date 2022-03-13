.section .data
	msg1: .string "Chu hoa" # Khai bao chuoi 1
	len1 = . -msg1 # lay do dai chuoi
	msg2: .string "Chu thuong" # Khai bao chuoi 2
	len2 = . -msg2 # lay do dai chuoi
	msg3: .string "Enter a character: " # Khai bao chuoi 3
	len3 = . -msg3 # lay do dai chuoi

.section .bss
	.lcomm input, 1 # khai bao o nho de xuat output

.section .text
	.globl _start

_start:

	movl $4, %eax
	movl $1, %ebx
	movl $msg3, %ecx
	movl $len3, %edx
	int $0x80 # xuat ra dong enter character

	movl $3, %eax
	movl $0, %ebx
	movl $input, %ecx
	movl $2, %edx
	int $0x80 # Nhap chu dau tien

	movl $0, %eax
	mov (input), %al # lay gia tri ASCII cua chu cai 
	cmpl $97, %eax # neu >= 97 thi la chu thuong con lai la chu hoa
	jl .Upper
	movl $4, %eax
	movl $1, %ebx
	movl $msg2, %ecx
	movl $len2, %edx
	int $0x80 # xuat ra dong chu thuong
	jmp .end
.Upper:
	movl $4, %eax
	movl $1, %ebx
	movl $msg1, %ecx
	movl $len1, %edx
	int $0x80 # xuat ra dong chu hoa
.end:
	movl $1, %eax
	movl $0, %ebx
	int $0x80 # ket thuc chuong trinh
