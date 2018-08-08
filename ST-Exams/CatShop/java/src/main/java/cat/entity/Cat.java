package cat.entity;

import javax.persistence.*;
import javax.validation.constraints.NotNull;

@Entity
@Table(name = "cats")
public class Cat {

    private Integer Id;

    private String Name;

    private String Nickname;

    private double Price;

    public Cat(String Name, String Nickname, double Price){
        this.Name = Name;
        this.Nickname = Nickname;
        this.Price = Price;
    }

    public Cat(){ }

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

    @Column(name = "nickname", nullable = false)
    public String getNickname() {
        return Nickname;
    }

    public void setNickname(String nickname) {
        Nickname = nickname;
    }

    @Column(name = "price", nullable = false)
    public double getPrice() {
        return Price;
    }

    public void setPrice(double price) {
        this.Price = price;
    }
}
