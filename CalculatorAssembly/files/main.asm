.data
	localArq: .asciiz "C:/Assembly Calculator/Input.txt"
	array:
		.align 2
		.space 8
	saudacao: .asciiz "Olá, digite dois valores inteiros =D\n"
		
.text
	move $t0, $zero #Indice do array
	move $t1, $zero	# valor a ser colocado no array
	move $t3, $zero	
	li $t4, 1
	
	li $v0, 4
	la $a0, saudacao
	syscall
	
	li $t2, 2	#tamanho do array
	addi $t5, $zero, 0
	
	jal le_inteiro_do_teclado
	
	li $v0, 10
	syscall

	le_inteiro_do_teclado:
		beq $t0, $t2, abreArq
			li $v0, 5	# código para ler um inteiro
			syscall			
			
			move $t1, $v0
			addi $t1, $t1, 48
			sb $t1, array($t0)
			addi $t0, $t0, 1	
			
			j le_inteiro_do_teclado
	abreArq:
		li $v0, 13           # Solicita a abertura do arquivo
		la $a0, localArq         # Endereï¿½o do arquivo no registrador $a0
		li $a1, 1            # abre para escrita 1
		syscall
		move $s0, $v0 
		j salva_arquivo
		jr $ra
			
	salva_arquivo:
		bge  $t3, $t2 fim		
		li $v0, 15           # Ler o conteúdo do arquivo que está referenciado em $a0 
		move $a0, $s0
		
		la $a1, array($t5)   #conteudo($t3)       # Registrador que armazena o conteúdo 
		addi $t5, $t5, 1
		move $a2, $t4        # Numeros de bytes que referenciam o tamanho do buffer
		syscall  	#Leitura realizada
		
		addi $t3, $t3, 1
		j salva_arquivo
	fim:
		li $v0, 16           
		move $a0, $s0        
		syscall 
		jr $ra