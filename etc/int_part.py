import math
inf = math.inf

def part(n):
  a = [1] * (n+1)
  def try_part(i = 1):
    return 0

# part(7)

def gen_sample(n):
  x = (n+1)*[1];
  t = (n+1)*[0];
  def try_sample(i):
    for j in range(x[i-1], n - t[i-1]+1):
      x[i] = j
      t[i] = t[i-1] + j
      if t[i] == n:
        print(x[0:])
      else:
        try_sample(i+1)
  try_sample(1)


gen_sample(6)