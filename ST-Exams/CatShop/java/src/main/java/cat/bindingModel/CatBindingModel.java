package cat.bindingModel;

import javax.validation.constraints.NotNull;

public class CatBindingModel {
    @NotNull
    private String name;

    @NotNull
    private String nickname;

    @NotNull
    public String getName() {
        return name;
    }

    public void setName(@NotNull String name) {
        this.name = name;
    }

    @NotNull
    public String getNickname() {
        return nickname;
    }

    public void setNickname(@NotNull String nickname) {
        this.nickname = nickname;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    @NotNull
    private double price;

}
