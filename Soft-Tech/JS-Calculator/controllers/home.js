const Calculator = require('../models/Calculator');

module.exports = {
    indexGet: (req, res) => {
        res.render('home/index');
    },
    indexPost: (req, res) => {
        let calculatorBody = req.body;

        let calculatorParams = calculatorBody["calculator"];
        let calculator = new Calculator();
        calculator.leftOperand = Number(calculatorParams.leftOperand);
        calculator.operator = calculatorParams.operator;
        calculator.rightOperand = Number(calculatorParams.rightOperand);

        if(isNaN(calculator.leftOperand) || isNaN(calculator.rightOperand)){
            let error = calculator.alertIfNan();
            res.render('home/index', {'calculator': calculator, 'errorForNumber': error});
            return;
        }

        let result = calculator.calculateResult();

        res.render('home/index', {'calculator': calculator, 'result': result});
    }
};