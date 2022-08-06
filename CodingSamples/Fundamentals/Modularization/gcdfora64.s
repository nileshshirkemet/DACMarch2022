	.text

GCD:
1:	cmp	x0, x1
	beq	3f
	blt	2f
	sub	x0, x0, x1
	b	1b
2:	sub	x1, x1, x0
	b	1b
3:	ret

	.global	GCD
	.type	GCD, %function

	.end

