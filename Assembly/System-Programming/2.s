.section .data
	msg: .string "enter a number: " # Khai bao chuoi
	len = . -msg # lay do dai chuoi

.section .bss
	.lcomm input, 2 # khai bao o nho de xuat output
	.lcomm input1, 2
	.lcomm input2, 2
	.lcomm input3, 2
	.lcomm output, 1

.section .text
	.globl _start

_start:
	call _Input

	movl $3, %eax
	movl $0, %ebx
	movl $input, %ecx
	movl $2, %edx
	int $0x80 # Nhap so dau tien

	call _Input

	movl $3, %eax
	movl $0, %ebx
	movl $input1, %ecx
	movl $2, %edx
	int $0x80 # Nhap so thu 2

	call _Input

	movl $3, %eax
	movl $0, %ebx
	movl $input2, %ecx
	movl $2, %edx
	int $0x80 # Nhap so thu 3

	call _Input

	movl $3, %eax
	movl $0, %ebx
	movl $input3, %ecx
	movl $2, %edx
	int $0x80 # Nhap so thu 4

	movl $0, %eax
	movl $0, %ebx
	mov (input), %bl
	add %ebx, %eax
	mov (input1), %bl
	add %ebx, %eax
	mov (input2), %bl
	add %ebx, %eax
	mov (input3), %bl
	add %ebx, %eax # cong cac so vao eax
	shrl $2, %eax # eax / 4
	mov %al, (output) # chuyen vao vung nho de xuat ra man hinh

	movl $4, %eax
	movl $1, %ebx
	movl $output,%ecx
	movl $1, %edx
	int $0x80 # xuat gia tri

	movl $1, %eax
	movl $0, %ebx
	int $0x80 # ket thuc chuong trinh

_Input:
	movl $4, %eax
	movl $1, %ebx
	movl $msg, %ecx
	movl $len, %edx
	int $0x80 # "xuat ra dong enter number"

	ret
