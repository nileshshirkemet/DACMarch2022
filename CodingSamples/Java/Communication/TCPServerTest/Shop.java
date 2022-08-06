import java.io.*;
import java.util.*;

class Shop {

	private Properties store;

	private Shop(Properties store) {
		this.store = store;
	}

	public static Shop open(String doc) throws IOException {
		Properties props = new Properties();
		try(var input = new FileInputStream(doc)){
			props.loadFromXML(input);
		}
		return new Shop(props);
	}

	public String getItemInfo(String name) {
		return store.getProperty(name);
	}
}

