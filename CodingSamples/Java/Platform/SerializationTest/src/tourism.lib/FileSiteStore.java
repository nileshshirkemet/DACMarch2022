package tourism.core;

import tourism.api.*;
import java.io.*;

public class FileSiteStore implements SiteStore {

	public boolean save(Site info) {
		String doc = info.getName() + ".store";
		try(var output = new ObjectOutputStream(new FileOutputStream(doc))){
			output.writeObject(info); //object serialization
			return true;
		}catch(Exception e){
			return false;
		}
	}

	public Site load(String name) {
		String doc = name + ".store";
		try(var input = new ObjectInputStream(new FileInputStream(doc))){
			return (Site)input.readObject(); //object deserialization
		}catch(Exception e){
			return new Site(name);
		}
	}
	
}

