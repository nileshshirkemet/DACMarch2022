package tourism.ui;

import tourism.api.*;

public class Program {

	public static void main(String[] args) {
		var store = SiteStore.open();
		var site = store.load("CitiZoo");
		if(args.length > 0){
			var visitor = site.getVisitor(args[0]);
			visitor.visit();
			System.out.printf("Welcome %s, your ticket number is %d%n", args[0], visitor.getTicket());
			store.save(site);
		}else{
			for(var visitor : site.getVisitors())
				System.out.printf("%s\t%d\t%s%n", visitor.getId(), visitor.getVisitCount(), visitor.getLastVisit());
		}
	}
}

