.section .data
	msg1: .string "Tang dan" # Khai bao chuoi 1
	len1 = . -msg1 # lay do dai chuoi
	msg2: .string "Khong tang dan" # Khai bao chuoi 2
	len2 = . -msg2 # lay do dai chuoi
	msg3: .string "Enter a character: " # Khai bao chuoi 3
	len3 = . -msg3 # lay do dai chuoi

.section .bss
	.lcomm input, 4 # khai bao o nho de xuat output

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
	movl $4, %edx
	int $0x80 # Nhap cac so

	movl $0, %eax
	movl $0, %ebx
	movl $input, %edx # lay dia chi input len edx
	mov (%edx), %al
	mov 1(%edx), %bl
	cmpl %ebx, %eax # so sanh so dau tien va so thu 2
	jg .Pha # Neu so dau lon hon so thu 2 thi nhay den khong tang dan
	mov 1(%edx), %al
	mov 2(%edx), %bl
	cmpl %ebx, %eax # so sanh so thu 2 va so thu 3
	jg .Pha # Neu so thu 2 lon hon so thu 3 thi nhay den khong tang dan
	movl $4, %eax
	movl $1, %ebx
	movl $msg1, %ecx
	movl $len1, %edx
	int $0x80 # xuat ra dong tang dan
	jmp .end # nhay den end
.Pha:
	movl $4, %eax
	movl $1, %ebx
	movl $msg2, %ecx
	movl $len2, %edx
	int $0x80 # xuat ra dong khong tang dan
.end:
	movl $1, %eax
	movl $0, %ebx
	int $0x80 # ket thuc chuong trinh


