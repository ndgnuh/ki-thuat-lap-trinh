using System;

namespace program{

public class Fraction
{
	private int deno;
	private int nume;

	public Fraction(int nume, int deno){
		this.deno = deno;
		this.nume = nume;
		this.Simplify();
	}

	// inner multiplication/addition
	public Fraction Inv() {
		return new Fraction(this.deno, this.nume);
	}

	public static Fraction operator -(Fraction frac) {
		return new Fraction(-frac.nume,frac.deno);
	}

	public static Fraction operator +(Fraction left, Fraction right) {
		return new Fraction(left.nume * right.deno + left.deno * right.nume, left.nume * right.nume);
	}
	
	public static Fraction operator -(Fraction left, Fraction right) {
		return new Fraction(left.nume * right.deno - left.deno * right.nume, left.nume * right.nume);
	}
	
	public static Fraction operator *(Fraction left, Fraction right) {
		return new Fraction(left.nume * right.nume, left.deno * right.deno);
	}
	
	public static Fraction operator /(Fraction left, Fraction right) {
		return new Fraction(left.nume *  right.deno, left.deno*right.nume);
	}

	// outer multiplication/addition
	public static Fraction operator +(Fraction left, int right) {
		return new Fraction(left.nume  + (right * left.deno), left.deno * right);
	}
	public static Fraction operator -(Fraction left, int right){
		return new Fraction(left.nume  - (right * left.deno), left.deno * right);
	}
	public static Fraction operator *(Fraction left, int right) {
		return new Fraction(left.nume  * right, left.deno);
	}
	public static Fraction operator /(Fraction left, int right) {
		return new Fraction(left.nume, left.deno * right);
	}

	
	public static Fraction operator +(int left, Fraction right) {
		return right + left;
	}
	public static Fraction operator -(int left, Fraction right) {
		return (-right) + left;
	}
	public static Fraction operator *(int left, Fraction right) {
		return right * left;
	}
	public static Fraction operator /(int left, Fraction right) {
		return right.Inv() * left;
	}
	
	// relation
	private bool IsPositive() {
		return this.deno * this.nume > 0;
	}
	public static bool operator >(Fraction left, Fraction right) {
		return (left - right).IsPositive();
	}

	public static bool operator <(Fraction left, Fraction right) {
		return (right - left).IsPositive();

	}
	public static  bool operator ==(Fraction left, Fraction right) {
		return left.deno*right.nume == right.deno * left.nume;
	}
	public static  bool operator !=(Fraction left, Fraction right) {
		return left.deno*right.nume != right.deno * left.nume;
	}
	public static  bool operator >=(Fraction left, Fraction right) {
		return left == right || left > right;
	}
	public static  bool operator <=(Fraction left, Fraction right) {
		return left == right || left < right;
	}

	
	private static int Gcd(int a, int b){
		int t = 0;
		while ( b != 0){
			t = b;
			b = a % b;
			a = t;
		}
		return a;
	}

	public void Simplify() {
		int gcd = Gcd(this.deno, this.nume);
		this.nume = this.nume / gcd;
		this.deno = this.deno / gcd;
		if(this.deno * this.nume < 0 && this.deno < 0) {
			this.deno = - this.deno;
			this.nume = - this.nume;
		}
	}

	public override string ToString(){
		if(this.deno == 0) return "inf";
		if(this.nume % this.deno == 0) {
			return Convert.ToString(this.nume / this.deno);
		}
		this.Simplify();
		return this.nume + "/" + this.deno;
	}
}
public class Program{
	public static void Main() {
		Fraction a = new Fraction(1,3);
		Fraction b = new Fraction(2,5);
		int c = 4;
		
		Console.WriteLine("=== inputs");
		Console.WriteLine("a = " + a);
		Console.WriteLine("b = " + b);
		Console.WriteLine("c = " + c);

		Console.WriteLine("===========");
		Console.WriteLine("a + b = " + (a+b));
		Console.WriteLine("a * b = " + (a*b));
		Console.WriteLine("a - b = " + (a-b));
		Console.WriteLine("a / b = " + (a/b));

		Console.WriteLine("===========");
		Console.WriteLine("a + c = " + (a+c));
		Console.WriteLine("c + a = " + (c+a));
		Console.WriteLine("a * c = " + (a*c));
		Console.WriteLine("c * a = " + (c*a));
		Console.WriteLine("a - c = " + (a-c));
		Console.WriteLine("c - a = " + (c-a));
		Console.WriteLine("c / a = " + (c/a));
		Console.WriteLine("a / c = " + (a/c));

		Console.WriteLine("===========");
		Console.WriteLine("a == a: " + (a == a));
		Console.WriteLine("a != a: " + (a != a));
		Console.WriteLine("a >= a: " + (a >= a));
		Console.WriteLine("a < b: " + (a > b));
		Console.WriteLine("a > b: " + (a < b));

	}
}

}
