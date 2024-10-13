# EXERCICIOS LINGUAGEM DE PROGRAMAÇÃO II

Nesta tarefa foram resolvidos os exercícios 1.3 (Rectangle), 1.6 (Account) e 1.9 (Ball) disponíveis no [link](https://www3.ntu.edu.sg/home/ehchua/programming/java/j3f_oopexercises.html)

## Pré-requisitos
Antes de começar, certifique-se de que você tem o .NET 8.0 instalado. Você pode verificar isso executando:

```
dotnet --version
```

Se você não tiver o .NET instalado, siga as instruções abaixo de acordo com sua distribuição.

### Arch Linux
1. **Instale o .NET SDK:**
   ```
   sudo pacman -S dotnet-sdk
   ```
### Debian
1. **Instale o .NET SDK:**

   ```
   sudo apt-get install -y dotnet-sdk-8.0
   ```

### Fedora

1. **Instale o .NET SDK:**

   ```
   sudo dnf install dotnet-sdk-8.0
   ```

## Clonando a Solução
Clone o repositório da solução usando o Git:

```
git clone https://github.com/PauloFH/LP2_Exercicies.git
cd LP2_Exercicies
```

## Estrutura da Solução

A solução contém três projetos:

- **The_Ball_Class**
- **The_Account_Class**
- **The_Rectangle_Class**

Antes de executar a solução, você precisa restaurar as dependências:

```
dotnet restore
```

## Compilando a Solução

Compile a solução para garantir que tudo está funcionando corretamente:

```
dotnet build
```

## Executando os Projetos
Para executar um dos projetos, navegue até o diretório do projeto e execute:
#### 1.3  Ex: The Rectangle Class
```
cd The_Rectangle_Class
dotnet run
```
Resultado:
```
Rectangle[length=1,2,width=3,4]
Rectangle[length=1,width=1]
Rectangle[length=5,6,width=7,8]
Length is: 5,6
Width is: 7,8
Area is: 43,68
Perimeter is: 26,80
```
#### 1.6  Ex: The Account Class
```
cd ..
cd The_Account_Class
dotnet run
```
Resultado:
```
Account[id=A101,name=Tan Ah Teck,balance=88]
Account[id=A102,name=Kumar,balance=0]
ID: A101
Name: Tan Ah Teck
Balance: 88
Account[id=A101,name=Tan Ah Teck,balance=88]
Account[id=A101,name=Tan Ah Teck,balance=38]
Amount exceeded balance
Account[id=A101,name=Tan Ah Teck,balance=38]
Amount exceeded balance
Account[id=A101,name=Tan Ah Teck,balance=38]
Account[id=A102,name=Kumar,balance=0]
```
#### 1.9  Ex: The Ball Class
```
cd ..
cd The_Ball_Class
dotnet run
```
Resultado: 
```
Ball[(0,00,0,00),speed=(0,00,0,00)]
Ball[(80,00,35,00),speed=(4,00,6,00)]
x is: 80,00
y is: 35,00
radius is: 5
xDelta is: 4,00
yDelta is: 6,00
Ball[(84,00,41,00),speed=(4,00,6,00)]
Ball[(88,00,47,00),speed=(4,00,6,00)]
Ball[(92,00,41,00),speed=(4,00,-6,00)]
Ball[(96,00,35,00),speed=(4,00,-6,00)]
Ball[(92,00,29,00),speed=(-4,00,-6,00)]
Ball[(88,00,23,00),speed=(-4,00,-6,00)]
Ball[(84,00,17,00),speed=(-4,00,-6,00)]
Ball[(80,00,11,00),speed=(-4,00,-6,00)]
Ball[(76,00,5,00),speed=(-4,00,-6,00)]
Ball[(72,00,-1,00),speed=(-4,00,-6,00)]
Ball[(68,00,5,00),speed=(-4,00,6,00)]
Ball[(64,00,11,00),speed=(-4,00,6,00)]
Ball[(60,00,17,00),speed=(-4,00,6,00)]
Ball[(56,00,23,00),speed=(-4,00,6,00)]
Ball[(52,00,29,00),speed=(-4,00,6,00)]
```

****