/*
                ******
		
        Author: Nguyen Phuc Chuong
        Author: Nguyen My Quynh

                ******
*/

#include <bits/stdc++.h>

using namespace std;

void PrintBits(unsigned int x) {
	for (int i = 8 * sizeof(x)-1; i >= 0; i--) {
		(x & (1 << i)) ? putchar('1') : putchar('0');
	}
	printf("\n");
}

void PrintBitsOfByte(unsigned int x) {
	for (int i = 7; i >= 0; i--) {
		(x & (1 << i)) ? putchar('1') : putchar('0');
	}
	printf("\n");
}

int bitAnd(int x, int y) {
	return ~(~x | ~y);
}

int negative(int x) {
	return ~x + 1;
}

int getBit(int x, int n) {
	return (x >> n) & 1;
}

int mulpw2(int x, int n) {
	return x >> (~n + 1);
}

int modulus2(int x, int n) {
	return x & ((1 << n) + ~1 + 1);
}

int isOdd(int x) {
	return x & 1;
}

int is8x(int x) {
	return !(x & 7);
}

int isPositive(int x) {
	return !((x + ~1 + 1) >> 31);
}

int isGE2n(int x, int n) {
	return !((x + ~(1 << n) + 1) >> 31);
}

int main() {
	int score = 0;
	//printf("%d\n", 8 >> -2);
	printf("Your evaluation result:");
	printf("\n1.1");
	if (bitAnd(3, -9) == (3 & -9))
	{
		printf("\tPass.");
		score += 1;
	}
	else
		printf("\tFailed.");

	printf("\n1.2");
	if (negative(0) == 0 && negative(9) == -9 && negative(-5) == 5)
	{
		printf("\tPass.");
		score += 1;
	}
	else
		printf("\tFailed.");

	printf("\n1.3");
	if (getBit(8, 0) == 0 && getBit(3, 1) == 1 && getBit(32, 5) == 1)
	{
		printf("\tPass.");
		score += 2;
	}
	else
		printf("\tFailed.");

	printf("\n1.4");
	if (mulpw2(10, -1) == 5 && mulpw2(15, -2) == 3 && mulpw2(103, -4) == 6)
	{
		printf("\tPass.");
		score += 3;
	}
	else
		printf("\tFailed.");

	printf("\n1.5");
	if (modulus2(2, 1) == 0 && modulus2(30, 2) == 2 && modulus2(63, 6) == 63)
	{
		printf("\tPass.");
		score += 3;
	}
	else
		printf("\tFailed.");

	printf("\n2.1");
	if (isOdd(3) && !isOdd(0) && !isOdd(12))
	{
		printf("\tPass.");
		score += 2;
	}
	else
		printf("\tFailed.");

	printf("\n2.2");
	if (is8x(16) && !is8x(3) && is8x(0))
	{
		printf("\tPass.");
		score += 2;
	}
	else
		printf("\tFailed.");

	printf("\n2.3");
	if (isPositive(10) && !isPositive(-5) && !isPositive(0))
	{
		printf("\tPass.");
		score += 3;
	}
	else
		printf("\tFailed.");

	printf("\n2.4");
	if (isGE2n(15, 1) && isGE2n(8, 3) && !isGE2n(12, 4))
	{
		printf("\tPass.");
		score += 3;
	}
	else
		printf("\tFailed.");

	printf("\n--- FINAL RESULT ---");
	printf("\nScore: %.1f", (float)score / 2);
	score /= 2;
	if (score < 5)
		printf("\nTrouble when solving these problems? Contact your instructor to get some hints :)");
	else
	{
		if (score < 8)
			printf("\nNice work. But try harder.");
		else
		{
			if (score == 10)
				printf("\nExcellent. We found a master in bit-wise operations :D");
			else
				printf("\nYou're almost there. Think more carefully in failed problems.");
		}
	}

	printf("\n\n\n");
	return 0;
}
