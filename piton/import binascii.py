import binascii
filename = "C:\\Users\\luchk\\Documents\\KIT_deze\\piton\\yippeesound.txt"
with open(filename, 'rb') as f:
    content = f.readline()
    print(content)
    unhexed = binascii.unhexlify(content)

a = open("yyippeesound.mp3","wb")
a.write(unhexed)