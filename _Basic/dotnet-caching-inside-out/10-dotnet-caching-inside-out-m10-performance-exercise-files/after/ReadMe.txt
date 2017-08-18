
Start RabbitMQ - check with http://localhost:15672 guest/guest
Start Papercut
Start 2x instances of console app
Start PasswordReset.com
Browse http://127.0.0.1:8012/passwordreset?emailAddress=cba@xyz.com - messages to Rabbit, picked up and sent to papercut

