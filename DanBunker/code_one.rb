# A O method
def o
  return __callee__
end

# A psuedo " " method
def _
  a = nil.object_id / nil.object_id
  b = a + a + a + a + a + a + a + a + a + a
  return Time.now.to_s[b,a]
end

# My ascii art array for Hello World
out_array = [
  [o,_,o,_,o,o,o,_,o,_,_,_,o,_,_,_,o,o,o,_,_,_,o,_,_,_,o,_,o,o,o,_,o,o,o,_,o,_,_,_,o,_,_,_,_,o],
  [o,_,o,_,o,_,_,_,o,_,_,_,o,_,_,_,o,_,o,_,_,_,o,_,_,_,o,_,o,_,o,_,o,_,o,_,o,_,_,_,o,o,_,_,_,o],
  [o,o,o,_,o,o,o,_,o,_,_,_,o,_,_,_,o,_,o,_,_,_,o,_,_,_,o,_,o,_,o,_,o,o,o,_,o,_,_,_,o,_,o,_,_,o],
  [o,_,o,_,o,_,_,_,o,_,_,_,o,_,_,_,o,_,o,_,_,_,o,_,o,_,o,_,o,_,o,_,o,o,_,_,o,_,_,_,o,o,_,_,_,_],
  [o,_,o,_,o,o,o,_,o,o,o,_,o,o,o,_,o,o,o,_,_,_,_,o,_,o,_,_,o,o,o,_,o,_,o,_,o,o,o,_,o,_,_,_,_,o]
]

# Print out my array and ultimately my message
out_array.each do |row|
  puts row.join
end
