from SimpleWebSocketServer import SimpleWebSocketServer, WebSocket

class SimpleEcho(WebSocket):

    def handleMessage(self):
        # echo message back to client
        print("receive data: " + self.data)
        self.sendMessage(self.data + " From Server")

    def handleConnected(self):
        print(self.address, 'connected')

    def handleClose(self):
        print(self.address, 'closed')

server = SimpleWebSocketServer('', 8000, SimpleEcho)
server.serveforever()