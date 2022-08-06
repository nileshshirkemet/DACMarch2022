package tourism.api;

import java.util.*;

public class Site implements java.io.Serializable {

	private String name;
	private List<Visitor> visitors;

	public Site(String name) {
		this.name = name;
		visitors = new ArrayList<>();
	}

	public String getName() { return name; }

	public List<Visitor> getVisitors() { return visitors; }

	public Visitor getVisitor(String name) {
		return visitors.stream()
				.filter(v -> v.id.equals(name))
				.findFirst()
				.orElseGet(() -> {
					Visitor v = new Visitor(name);
					visitors.add(v);
					return v;
				});
	}

	static final long serialVersionUID = 1L;
}

