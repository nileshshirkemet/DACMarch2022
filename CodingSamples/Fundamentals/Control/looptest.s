	.set sysarch, _x64_
	.include "console.i"

	.text

	.entry main
main:	
	GetInt	askn, num
	
	mov	rax, 1
	mov	rbx, num
	sub	rcx, rcx	#mov rcx, 0

1:	mov	rdx, 10
	mul	rdx		#imul rax, rdx
	inc	rcx		#add	rcx, 1

	cmp	rax, rbx
	jle	1b		#relative jump to instruction labelled 1 in backward direction

	mov	digits, rcx

	PutInt	tell, digits

1:	ret

askn:	.string	"Positive Integer: "
tell:	.string	"Number of Digits: "

	.data

num:	.quad	0
digits:	.quad	0

	.end

