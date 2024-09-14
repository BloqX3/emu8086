
# emu8086 - 2024

a modern and powerful replacement for emu8086 program for simulating microproccessor 8086 architecture programming


## Syntax

```assembly
MOV AX 1  ;move decimal 1 to register AX
MOV BX 2
add AX BX ;AX = AX + BX
mov cx 2

          ;Looping 2 times:
LOOP:
MUL 2   ;AX = 2*AX
dec cx
cmp cx 0
jne LOOP
push AX ;add results to stack
```
