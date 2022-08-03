package com.jdbc.test;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;

import com.met.model.Account;

public class JDBCTest {

	
	private void saveUsingJDBC(Account account){
		
		try{
			Class.forName("com.mysql.jdbc.Driver");
		}catch(ClassNotFoundException ex){
			System.out.println("Kindly add MYSql drivers in classpath");
			return;
		}
		
		
		try(
				Connection connection = DriverManager.getConnection("jdbc:mysql://localhost:3306/sales", "root", "dinesh");
				PreparedStatement pstmt = connection.prepareStatement("insert into Account values(?, ?, ?)");
				
				){
			
					pstmt.setInt(1, account.getId());
					pstmt.setString(2, account.getName());
					pstmt.setDouble(3, account.getBalance());
			
			
					/*pstmt.setString(4, "Mumbai");
					pstmt.setString(4, "India");*/
					
					
					
					pstmt.executeUpdate();
					
					System.out.println("Account with id "+ account.getId() + " saved to DB");
			
		}catch (SQLException e) {
			//roll back
			
			e.printStackTrace();
		}
		
		
	}
	
	public static void main(String[] args) {
		Account account = new Account();
		account.setId(1);
		account.setName("Rahul");
		account.setBalance(60000.0);
		
		
		JDBCTest test = new JDBCTest();
		test.saveUsingJDBC(account);
		
	}
	
	
}
