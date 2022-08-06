package simple.web.app;

import java.io.*;
import jakarta.servlet.*;
import jakarta.servlet.annotation.*;

@WebFilter("/*")
public class PausingFilter implements Filter {

	private long recent;
	
	public void init(FilterConfig cfg) throws ServletException {}

	public void doFilter(ServletRequest request, ServletResponse response, FilterChain next) throws IOException, ServletException {
		long now = System.currentTimeMillis();
		if(now - recent >= 5000){
			recent = now;
			next.doFilter(request, response);
		}else{
			var out = response.getWriter();
			out.println("Server is busy, try after some time...");
			out.close();
		}
	}

	public void destroy() {}
}

