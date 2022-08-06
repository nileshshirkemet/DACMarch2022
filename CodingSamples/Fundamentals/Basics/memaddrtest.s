	.set sysarch, _x64_
	.include "console.i"

	//read-only segment for program code and constants
	.text

	.entry main
main:
	GetInt	asku, upper

	mov	rax, upper	#rax=upper
	mov	rcx, rax	#rcx=upper
	add	rcx, 1		#rcx=upper+1
	imul	rax, rcx	#rax=upper*(upper+1)
	shr	rax, 1		#rax=upper*(upper+1)/2
	mov	total, rax	#total=rax

	PutInt	tell, total

	ret

asku:	.string	"Upper Limit: "
tell:	.string	"Sum of Integers = "

	//writeable segment for program variables
	.data

#assigning memory block for a 64-bit integer value (quad word) 
#and linking its logical address to name upper
total:	.quad	0
upper:	.quad	0


	.end

