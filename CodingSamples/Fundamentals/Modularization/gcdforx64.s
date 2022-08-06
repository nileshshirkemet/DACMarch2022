	.intel_syntax noprefix

	.text

GCD:
1:	cmp	rdi, rsi
	je	3f
	jl	2f
	sub	rdi, rsi
	jmp	1b
2:	sub	rsi, rdi
	jmp	1b
3:	mov	rax, rdi
	ret

	.global	GCD		#publishing GCD
	.type	GCD, @function  #GCD label identifies a function

	.end

