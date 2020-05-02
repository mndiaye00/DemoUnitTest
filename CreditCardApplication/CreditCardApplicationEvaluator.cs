using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardApplication
{
    public class CreditCardApplicationEvaluator
    {
        private readonly IFrequentFlyerNumberValidator _validator;

        private const int AutoReferralMaxAge = 20;
        private const int HighIncomeThreshhold = 100_000;
        private const int LowIncomeThreshhold = 20_000;

        public CreditCardApplicationEvaluator(IFrequentFlyerNumberValidator validator)
        {
            _validator = validator ?? throw new ArgumentNullException(nameof(validator));
        }

        public CreditCardApplicationDecision Evaluate(CreditCardApplication application)
        {
            if (application.GrossAnnualIncome >= HighIncomeThreshhold)
            {
                return CreditCardApplicationDecision.AutoAccepted;
            }

            var isValidFrequentFlyerNumber = _validator.IsValid(application.FrequentFlyerNumber);

            if (!isValidFrequentFlyerNumber)
            {
                return CreditCardApplicationDecision.ReferedToHuman;
            }

            if(application.Age <= AutoReferralMaxAge)
            {
                return CreditCardApplicationDecision.ReferedToHuman;
            }

            if (application.GrossAnnualIncome < LowIncomeThreshhold)
            {
                return CreditCardApplicationDecision.AutoDeclined;
            }

            return CreditCardApplicationDecision.ReferedToHuman;
        }

    }
}
