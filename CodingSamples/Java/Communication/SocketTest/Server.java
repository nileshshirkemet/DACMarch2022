import java.net.*;
import java.nio.*;
import java.nio.file.*;
import java.nio.channels.*;

class Server {

	public static final String NAME = "encryption.sock";

	public static void run() throws java.io.IOException {
		Files.deleteIfExists(Path.of(NAME));
		//Step 1
		var listener = ServerSocketChannel.open(StandardProtocolFamily.UNIX);
		listener.bind(UnixDomainSocketAddress.of(NAME));
		for(;;){
			//Step 2
			var client = listener.accept();
			//Step 3
			var buffer = ByteBuffer.allocate(80);
			int n = client.read(buffer);
			Transformer.transform(buffer.flip().array(), n);
			client.write(buffer);
			//Step 4
			client.close();
		}
	}
}

