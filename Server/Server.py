import socket
HOST = ""
PORT=18520

stored=""

print("SETUP")
with socket.socket(socket.AF_INET , socket.SOCK_STREAM) as s:
    print("HOSTING")
    s.bind((HOST,PORT))
    s.listen()
    print("ONLINE")
    while 1:
        conn,addr = s.accept()
        print(f'{stored=}')
        with conn:
            print(f'Connection from {addr}')
            string =""
            while 1:
                data = conn.recv(1024)
                if not data:
                   break
                string += data.decode("ascii")
                if string.endswith("EOF"):break
            print(f'Received {string}')
            if string[:3] == "SET":
                print("SET")
                stored = string[3:-3] + "EOF"
                conn.sendall(b"Sucessfully Set Data")
            elif string[:3] == "GET":
                print("GET")
                conn.sendall(stored.encode("ascii"))
            
            