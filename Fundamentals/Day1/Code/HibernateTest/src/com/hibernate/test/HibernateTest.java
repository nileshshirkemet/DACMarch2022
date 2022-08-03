package com.hibernate.test;

import java.io.Serializable;

import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.Transaction;
import org.hibernate.cfg.Configuration;

import com.met.model.Account;

public class HibernateTest {

	private static SessionFactory sessionFactory = new Configuration().configure().buildSessionFactory();
	
	
	/*{
		
		Configuration configuration = new Configuration();
		Configuration cfg = configuration.configure();
		sessionFactory = cfg.buildSessionFactory();
	}*/
	
	
	private void saveUsingHibernate(Account acc){
		
		try(Session session = sessionFactory.openSession()){
			
			Transaction  tx = session.beginTransaction();
			
			//session.persist(acc);
			
			
			Serializable idValue = session.save(acc);
			
			System.out.println("Post Save with id ::    " + idValue) ;
			
			//System.out.println("Post Persist ::    ");			
			
			//session.flush();
			
			tx.commit();
				//1 -> Fire SQL querey to save/update... to db    --->   session.flush()
				//2 -> commit the tx
			
			
			//tx.commit -> session.flush() + commit 
			
			System.out.println("Account with id: " + acc.getId() + " saved to db");
			
		}
		
	}

	public static void main(String[] args) {
		
		Account acc = new Account();
		acc.setId(11);
		acc.setName("Kapil");
		acc.setBalance(50000);
		
		
		HibernateTest hibernateTest = new HibernateTest();
		hibernateTest.saveUsingHibernate(acc);
		try {
			Thread.sleep(5000000);
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		
	}
	
}
