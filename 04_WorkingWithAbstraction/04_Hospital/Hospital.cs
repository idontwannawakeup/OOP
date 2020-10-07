using System.Collections.Generic;

namespace _04_Hospital
{
    class Hospital
    {
        public List<Department> Departments { get; }
        private List<Doctor> Doctors = new List<Doctor>();

        public void PrintInfo(string output)
        {
            string[] info = output.Split(' ');

            if (info.Length == 1)
            {
                foreach (var department in Departments)
                    if (department.Name.Equals(info[0]))
                        department.Print();
            }
            else if (info.Length == 2 && int.TryParse(info[1], out int roomIdx))
            {
                foreach (var department in Departments)
                    if (department.Name.Equals(info[0]))
                        department.Print(roomIdx - 1);
            }
            else
            {
                foreach (var doctor in Doctors)
                    if (doctor.Name.Equals(output))
                        doctor.PrintPatients();
            }
        }

        public void UpdateInfo(string departmentName, string doctorName, string patientName)
        {
            bool isDoctorInList = false;
            foreach (var doctor in Doctors)
                if (doctor.Name.Equals(doctorName))
                {
                    doctor.AddPatient(patientName);
                    isDoctorInList = true;
                    break;
                }

            if (!isDoctorInList)
                Doctors.Add(new Doctor(doctorName, patientName));

            Department departmentToUpdate = null;
            foreach (var department in Departments)
                if (department.Name.Equals(departmentName))
                    departmentToUpdate = department;

            if (departmentToUpdate != null && !departmentToUpdate.IsFull)
                departmentToUpdate.UpdateInfo(patientName);
            else if (departmentToUpdate == null)
                Departments.Add(new Department(departmentName, patientName));
        }

        public Hospital()
        {
            Departments = new List<Department>();
        }
    }
}
