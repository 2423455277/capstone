# CS_ARCH_MIPS, CS_MODE_MIPS32, None
0x24,0x48,0xc7,0x00 = and $t1, $a2, $a3
0x67,0x45,0xc9,0x30 = andi $t1, $a2, 17767
0x67,0x45,0xc9,0x30 = andi $t1, $a2, 17767
0x67,0x45,0x29,0x31 = andi $t1, $t1, 17767
0x21,0x30,0xe6,0x70 = clo $a2, $a3
0x20,0x30,0xe6,0x70 = clz $a2, $a3
0x84,0x61,0x33,0x7d = ins $s3, $t1, 6, 7
0x27,0x48,0xc7,0x00 = nor $t1, $a2, $a3
0x25,0x18,0x65,0x00 = or $v1, $v1, $a1
0x67,0x45,0xa4,0x34 = ori $a0, $a1, 17767
0x67,0x45,0xc9,0x34 = ori $t1, $a2, 17767
0x80,0x00,0x6b,0x35 = ori $t3, $at1, 128
0xc2,0x49,0x26,0x00 = rotr $t1, $a2, 7
0x46,0x48,0xe6,0x00 = rotrv $t1, $a2, $a3
0xc0,0x21,0x03,0x00 = sll $a0, $v1, 7
0x04,0x10,0xa3,0x00 = sllv $v0, $v1, $a1
0x2a,0x18,0x65,0x00 = slt $v1, $v1, $a1
0x67,0x00,0x63,0x28 = slti $v1, $v1, 103
0x67,0x00,0x63,0x28 = slti $v1, $v1, 103
0x67,0x00,0x63,0x2c = sltiu $v1, $v1, 103
0x2b,0x18,0x65,0x00 = sltu $v1, $v1, $a1
0xc3,0x21,0x03,0x00 = sra $a0, $v1, 7
0x07,0x10,0xa3,0x00 = srav $v0, $v1, $a1
0xc2,0x21,0x03,0x00 = srl $a0, $v1, 7
0x06,0x10,0xa3,0x00 = srlv $v0, $v1, $a1
0x26,0x18,0x65,0x00 = xor $v1, $v1, $a1
0x67,0x45,0xc9,0x38 = xori $t1, $a2, 17767
0x67,0x45,0xc9,0x38 = xori $t1, $a2, 17767
0x0c,0x00,0x6b,0x39 = xori $t3, $at1, 12
0xa0,0x30,0x07,0x7c = wsbh $a2, $a3
0x27,0x38,0x00,0x01 = not $a3, $t0
0x20,0x48,0xc7,0x00 = add $t1, $a2, $a3
0x67,0x45,0xc9,0x20 = addi $t1, $a2, 17767
0x67,0xc5,0xc9,0x24 = addiu $t1, $a2, -15001
0x67,0x45,0xc9,0x20 = addi $t1, $a2, 17767
0x67,0x45,0x29,0x21 = addi $t1, $t1, 17767
0x67,0xc5,0xc9,0x24 = addiu $t1, $a2, -15001
0x28,0x00,0x6b,0x25 = addiu $t3, $at1, 40
0x21,0x48,0xc7,0x00 = addu $t1, $a2, $a3
0x00,0x00,0xc7,0x70 = madd $a2, $a3
0x01,0x00,0xc7,0x70 = maddu $a2, $a3
0x04,0x00,0xc7,0x70 = msub $a2, $a3
0x05,0x00,0xc7,0x70 = msubu $a2, $a3
0x18,0x00,0x65,0x00 = mult $v1, $a1
0x19,0x00,0x65,0x00 = multu $v1, $a1
0x22,0x48,0xc7,0x00 = sub $t1, $a2, $a3
0xc8,0xff,0xbd,0x23 = addi $sp, $sp, -56
0x23,0x20,0x65,0x00 = subu $a0, $v1, $a1
0xd8,0xff,0xbd,0x27 = addiu $sp, $sp, -40
0x22,0x30,0x07,0x00 = neg $a2, $a3
0x23,0x30,0x07,0x00 = negu $a2, $a3
0x21,0x38,0x00,0x01 = move $a3, $t0
