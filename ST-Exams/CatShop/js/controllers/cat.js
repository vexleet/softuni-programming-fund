const Cat = require('../models').Cat;

module.exports = {
    index: (req, res) => {
        Cat.findAll().then(cats => {
            res.render("cat/index", {
                cats: cats
            });
        });

    },

    createGet: (req, res) => {
        res.render("cat/create");
    },

    createPost: (req, res) => {
        let args = req.body.cat;

        if(args.name === "" || args.nickname === "" || args.price === ""){
            res.render("cat/create", {
               cat: args,
            });

            return;
        }

        Cat.create(args).then(() => {
            res.redirect('/');
        })

    },

    editGet: (req, res) => {
        let catId = req.params.id;

        Cat.findById(catId)
            .then(cat => {
                res.render("cat/edit", {
                    cat: cat
                });
            });
    },

    editPost: (req, res) => {
        let catId = req.params.id;
        let args = req.body.cat;

        if(args.name === "" || args.nickname === "" || args.price === ""){
            res.render("cat/edit", {
                cat: args,
            });

            return;
        }

        Cat.findById(catId).then(cat => {
            cat.update({
                name: args.name,
                nickname: args.nickname,
                price: args.price,
            });

            res.redirect("/");
        });
    },

    deleteGet: (req, res) => {
        let catId = req.params.id;

        Cat.findById(catId)
            .then(cat => {
                res.render("cat/delete", {
                    cat: cat
                });
            });
    },

    deletePost: (req, res) => {
        let catId = req.params.id;

        Cat.findById(catId)
            .then(cat => {
                cat.destroy({force: true});

                res.redirect("/");
            });
    }
};
