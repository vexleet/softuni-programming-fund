const Sequelize = require('sequelize');

module.exports = function (sequelize) {
    let Baby = sequelize.define('Baby', {
        name: {
            type: Sequelize.STRING,
            allowNull: false,
            required: true
        },
        gender: {
            type: Sequelize.STRING,
            allowNull: false,
            required: true,
        },
        birthday: {
            type: Sequelize.STRING,
            allowNull: false,
            required: true,
        }

    }, {
        timestamps: false
    });

    return Baby;
};