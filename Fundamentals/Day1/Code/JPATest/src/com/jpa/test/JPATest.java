package com.jpa.test;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.EntityTransaction;
import javax.persistence.Persistence;

import com.jdbc.test.JDBCTest;
import com.met.model.Account;

public class JPATest {

	private static EntityManagerFactory emf = Persistence.createEntityManagerFactory("jpaTest");
	
	private void saveUsingJPA(Account acc){
		
		EntityManager entityManager = null;
		EntityTransaction entityTransaction = null;
		
		try{
			
		    entityManager = emf.createEntityManager();
			
			System.out.println("Entity Manager :: " + entityManager.getClass());
			
			entityTransaction = entityManager.getTransaction();
			
			System.out.println("Entity Transaction :: " + entityTransaction.getClass());
			
			entityTransaction.begin();
			
			entityManager.persist(acc);
			
			entityTransaction.commit();
			
			
			
		}finally{
			if(entityManager != null) entityManager.close();
		}
		
		
		
	}
	
	public static void main(String[] args) {
		Account account = new Account();
		account.setId(3);
		account.setName("Rohan");
		account.setBalance(60000.0);
		
		JPATest test = new JPATest();
		test.saveUsingJPA(account);
		
		
	}
	
	
}
