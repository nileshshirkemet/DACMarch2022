package shopping;

import javax.persistence.*;

@Entity
@Table(name="counters")
public class CounterEntity implements java.io.Serializable {

	private String name;

	private int currentValue;

	@Id
	@Column(name="ctr_name")
	public String getName() { return name; }
	public void setName(String value) { name = value; }

	@Column(name="cur_val")
	public int getCurrentValue() { return currentValue; }
	public void setCurrentValue(int value) { currentValue = value; }
	
	public int getNextValue() { return ++currentValue; }

}

