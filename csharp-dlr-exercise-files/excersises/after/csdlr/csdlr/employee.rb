class Employee
   attr_accessor :firstName

   def add(property)
      class_eval { attr_accessor property }
   end

end

Employee.class_eval { attr_accessor :lastName }

e = Employee.new
e.lastName = "Allen"
puts e.lastName
puts e.firstName