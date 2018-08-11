package softuniBabies.bindingModel;

import javax.validation.constraints.NotNull;

public class BabyBindingModel {
    @NotNull
    private String name;

    @NotNull
    private String gender;

    @NotNull
    private String birthday;

    @NotNull
    public String getName() {
        return name;
    }

    public void setName(@NotNull String name) {
        this.name = name;
    }

    @NotNull
    public String getGender() {
        return gender;
    }

    public void setGender(@NotNull String gender) {
        this.gender = gender;
    }

    @NotNull
    public String getBirthday() {
        return birthday;
    }

    public void setBirthday(@NotNull String birthday) {
        this.birthday = birthday;
    }
}
