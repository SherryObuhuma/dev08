Create 12 and 5 subnets from the IP 192.168.75.0
Class C
Subnet Mask - 255.255.255.0
CIDR Range - 192.168.75.0/24
Binary - 11000000.10101000.01001011.00000000

Create 5 subnets
-----------------
Number of subnets = 2^Number
n = 3
Updated binary notation - 11100000

Number of hosts = 2^5 (We use because of the 5 remaining host bits)
                = 32
                Increments of 32
New subnet mask - 255.255.255.224
CIDR Range - 24+3
            = 27
            =192.168.75.0/27
Subnet Masks
-----------
1. 192.168.75.0 - 192.168.75.31/27
2. 192.168.75.32 - 192.168.75.63/27
3. 192.168.75.64 - 192.168.75.95/27
4.192.168.75.96 - 192.168.75.128/27
5.192.168.75.129 - 192.168.75.160/27

