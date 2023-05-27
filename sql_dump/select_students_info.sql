SELECT
Students.id as id,
Students.fio_stud as fio_stud,
Students.g_stud as stud_g,
Students.avatar as avatar,
Student_info.birthday as birthday,
Student_info.phone as phone,
Student_info.pasport as pasport,
Student_info.education as education,
Student_info.address_in_stav as address_in_stav,
Student_info.propiska as propiska,
Student_info.family_status as family_status,
Student_info.Accounting_of_ODN as odn,
Student_info.Fio_mam as fio_mam,
Student_info.fio_pap as fio_pap,
Student_info.phone_mam as phone_mam,
Student_info.phone_pap as phone_pap,
Student_info.address_family as address_family,
Student_info.nationalnost as nationalnost
FROM Students 
LEFT JOIN Student_info ON Students.id = Student_info.stud_id 
WHERE Students.id = {id}

