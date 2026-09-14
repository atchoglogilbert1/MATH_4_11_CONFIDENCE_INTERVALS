# MATH_4_11_CONFIDENCE_INTERVALS

## Point Estimate

A **point estimate** is a single number used to estimate an unknown population value.

Example:

- Sample mean: 125 ms
- Point estimate: 125 ms

**Point estimate = best single estimate**

**Confidence interval = range of plausible values**

## Confidence Intervals

A confidence interval is used to estimate an unknown population value using data from a sample.

### Point Estimate

A **point estimate** is a single value used as the best estimate of an unknown population value.

For example, the sample mean can be used to estimate the true population mean.

$$
\bar{x} = 125
$$

Here, **125** is the point estimate.

### Standard Error

The **standard error** describes how much the point estimate is expected to vary between different samples.

For a sample mean:

$$
SE = \frac{s}{\sqrt{n}}
$$

where:

* \(s\) = sample standard deviation
* \(n\) = sample size

A smaller standard error means the estimate is more precise.

### Confidence Level

The **confidence level** determines how reliable the confidence interval procedure should be.

Common confidence levels are:

* 90%
* 95%
* 99%

For example, with a 95% confidence level, if the sampling process were repeated many times, about 95% of the constructed intervals would contain the true population value.

### Critical Value

The **critical value** determines how many standard errors should be included around the point estimate.

For the standard normal distribution:

| Confidence Level | Critical Value |
| ---------------- | -------------: |
| 90%              |          1.645 |
| 95%              |           1.96 |
| 99%              |          2.576 |

For example:

$$
95\% \rightarrow 1.96
$$

### Margin of Error

The **margin of error** determines how far the confidence interval extends from the point estimate.

$$
ME = \text{Critical Value} \times SE
$$

### Confidence Interval

The confidence interval is calculated using:

$$
CI = \text{Point Estimate} \pm \text{Margin of Error}
$$

or:

$$
CI = \bar{x} \pm z^*SE
$$

For example:

$$
\bar{x}=100,\quad SE=5,\quad z^*=1.96
$$

$$
ME=1.96\times5=9.8
$$

Therefore:

$$
CI=[90.2,109.8]
$$

### Interpretation

The point estimate gives the **best single estimate**.

The standard error describes the **uncertainty of that estimate**.

The confidence level determines the desired **reliability**.

The critical value converts that confidence level into a number of standard errors.

The margin of error determines the width around the estimate.

Together, they produce the **confidence interval**.
