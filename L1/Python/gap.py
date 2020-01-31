def stringToList(string):
    lista=[]
    for a in string:
        lista.append(a)
    return lista
def intToBinaryString(inteiro):
    string=str(bin(inteiro))[2:]
    return string


def hasBinary(lista):
    i=0
    start=False
    Maxlen=0
    Minlen=0
    
    while i<len(lista)-1:
        
        if lista[i]=='1' and lista[i+1]=='0':
            Minlen=0
            start=True
            Minlen+=1
        elif start==True and lista[i]=='0' and lista[i+1]=='0':
            
            Minlen+=1
        elif start==True and lista[i]=='0' and lista[i+1]=='1':
            
            if Minlen>Maxlen:
                temp=Minlen
                Minlen=Maxlen
                Maxlen=temp
                start=False
            
        else:
            start=False
        i+=1
        
    return Maxlen    


def solution(N):
    string=intToBinaryString(N)
    lista=stringToList(string)
    gap=hasBinary(lista)
    return gap
