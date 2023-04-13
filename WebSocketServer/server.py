from SimpleWebSocketServer import SimpleWebSocketServer, WebSocket
from urllib.parse import urlparse, parse_qs
import re



class SimpleEcho(WebSocket):

    def handleMessage(self):
        # echo message back to client
        print("receive data: " + self.data)
        self.sendMessage(self.data + " From Server  " + self.request )

    def handleConnected(self):
        #print(self.client, 'connected  ' )
        pass

    def handleConnectedWithHeader(self, header):
        match = re.search(r"token=([\w\d\S]+)\s", header.decode('utf-8'))
        token = match.group(1)
        if token == "thisisavalidtoken" :
            print("connected")
        else:
            print("not connected")
            raise Exception("token is not valid")
    
    def handleClose(self):
        print(self.address, 'closed')

server = SimpleWebSocketServer('', 8000, SimpleEcho)
server.serveforever()