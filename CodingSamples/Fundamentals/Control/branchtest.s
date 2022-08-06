	.set sysarch, _x64_
	.include "console.i"

	.text

	.entry main
main:
	GetInt	askl, lower
	GetInt	asku, upper

	mov	rax, upper
	cmp	rax, lower	#compare two operands and accordingly set the state of the machine
	jl	done		#if in previous comparison, first operand is less than second operand jump to instruction with label done
	mov	rcx, rax
	add	rcx, 1
	imul	rax, rcx
	shr	rax, 1
	mov	rbx, rax
	mov	rax, lower
	sub	rax, 1
	mov	rcx, rax
	add	rcx, 1
	imul	rax, rcx
	shr	rax, 1
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

