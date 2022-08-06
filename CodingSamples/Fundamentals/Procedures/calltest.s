	.set sysarch, _x64_
	.include "console.i"

	.text

Compute: #procedure
	mov	rcx, rax
	add	rcx, 1
	imul	rax, rcx
	shr	rax, 1

	ret		#control will be transferrd to the instruction after the current call


	.entry main
main:
	GetInt	askl, lower
	GetInt	asku, upper

	mov	rax, upper
	cmp	rax, lower	
	jl	done
	call	Compute		#control will be transferred to instruction labelled Compute
	mov	rbx, rax
	mov	rax, lower
	sub	rax, 1
	call	Compute
	sub	rbx, rax
	mov	total, rbx

	PutInt	tell, total

done:	PutMsg	leave
	ret



askl:	.string	"Lower Limit: "
asku:	.string	"Upper Limit: "
tell:	.string	"Sum of Integers = "
leave:	.string	"Goodbye.\n"

	.data

lower:	.quad	0
upper:	.quad	0
total:	.quad	0

	.end

