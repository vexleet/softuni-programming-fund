package softuniBabies.entity;

import javax.persistence.*;

@Entity
@Table(name = "babies")
public class Baby {
   private Integer Id;

   private String Name;

   private String Gender;

   private String Birthday;

   public Baby(String Name, String Gender, String Birthday){
       this.Name = Name;
       this.Gender = Gender;
       this.Birthday = Birthday;
   }

   public Baby() { }

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public Integer getId() {
        return Id;
    }

    public void setId(Integer id) {
        Id = id;
    }

    @Column(name = "name", nullable = false)
    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    @Column(name = "gender", nullable = false)
    public String getGender() {
        return Gender;
    }

    public void setGender(String gender) {
        Gender = gender;
    }

    @Column(name = "birthday", nullable = false)
    public String getBirthday() {
        return Birthday;
    }

    public void setBirthday(String birthday) {
        Birthday = birthday;
    }
}
