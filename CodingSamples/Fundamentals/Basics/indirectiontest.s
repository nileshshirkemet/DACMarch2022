	.set sysarch, _x64_
	.include "console.i"

	.text

	.entry main
main:	
	GetInt	askm, month
	
	mov	rcx, month		#direct addressing => mov rcx, [address-linked-to-month]       mov     rcx, [month]
	sub	rcx, 1
	mov	rbx, offset year	#mov rbx, address_linked_to_year
	mov	rax, [rbx+8*rcx]	#indirect addressing or indirection

	PutInt	tell			#output value in rax

	ret

askm:	.string	"Month[1-12]: "
tell:	.string	"Number of Days = "
year:	.quad	31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31              [7000 + 8 * 4]  [7032]
               7000 08 

	.data

month:	.quad	0

	.end

