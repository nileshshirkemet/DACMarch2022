import ctypes

lib = ctypes.CDLL("./primes.so")
n = int(input("Upper Limit: "))
print("Number of primes =", lib.CountPrimes(1, n))

