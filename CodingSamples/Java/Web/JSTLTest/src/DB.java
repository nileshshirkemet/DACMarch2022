package classic.web.app;

import java.sql.*;
import com.mysql.cj.jdbc.*;
//import oracle.jdbc.pool.*;

class DB {

	private static MysqlConnectionPoolDataSource pool;
	//private static OracleConnectionPoolDataSource pool;

	public static Connection connect() throws SQLException {
		if(pool == null){
			pool = new MysqlConnectionPoolDataSource();
			pool.setURL("jdbc:mysql://localhost/sales?useSSL=false");
			pool.setUser("dbpro");
			pool.setPassword("Dbpro@789");
		}
		return pool.getConnection();
	}
}


