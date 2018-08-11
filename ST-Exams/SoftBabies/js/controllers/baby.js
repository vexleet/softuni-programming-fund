const Baby = require('../models').Baby;

module.exports = {
    index: (req, res) => {
       Baby.findAll()
           .then(babies => {
               res.render("baby/index", {
                   "babies": babies
               })
           });
    },

    createGet: (req, res) => {
        res.render("baby/create");
    },

    createPost: (req, res) => {
        let args = req.body.baby;

        Baby.create(args).then(() => {
            res.redirect('/');
        })
    },

    editGet: (req, res) => {
        let babyId = req.params.id;

        Baby.findById(babyId)
            .then(baby => {
                res.render("baby/edit", {
                    "baby": baby
                })
            })
    },

    editPost: (req, res) => {
        let babyid = req.params.id;
        let args = req.body.baby;

        Baby.findById(babyid)
            .then(baby => {
                baby.update({
                    name: args.name,
                    gender: args.gender,
                    birthday: args.birthday
                })
            });

        res.redirect("/");
    },

    deleteGet: (req, res) => {
        let babyId = req.params.id;

        Baby.findById(babyId)
            .then(baby => {
                res.render("baby/delete", {
                    "baby": baby
                })
            })
    },

    deletePost: (req, res) => {
        let babyId = req.params.id;

        Baby.findById(babyId)
            .then(baby => {
                baby.destroy({force: true});
            });

        res.redirect("/");
    }
};