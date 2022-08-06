	.set sysarch, _x64_
	.include "console.i"

	.text

	.entry begin
begin:	
	PutMsg	greet	
	ret

greet:	.string	"Hello World!\n"

	.end

