
$.validator.addMethod("primenumber", function (value, element, params) {
    if (value) {
        if (value == 1)
            return false;
        if (value == 2)
            return false;

        for (var i = 3; i < value; i = i + 2) {
            if (value % i == 0) return false;
        }
    }
    return true;
});


$.validator.unobtrusive.adapters.add('primenumber'
                                    , ['primenumberparam1', 'primenumberparam2']
                                    , function (options) {
                                        options.rules["primenumber"] = {
                                            primenumberparam1: options.params.primenumberparam1,
                                            primenumberparam2: options.params.primenumberparam2
                                        };
                                        options.messages["primenumber"] = options.message;
                                    }
                                    );
