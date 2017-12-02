//#include "stm32f10x.h"
#include "CONFIG.h"
#include "stm32f10x_nvic.h"
//#include"stm32f10x_flash.h"
/**************
*clock config
*******************/
void RCC_Configuration(void)
{
	//SystemInit();
	ErrorStatus	HSEStartUpStatus;
	RCC_DeInit();
	//
	RCC_HSEConfig(RCC_HSE_ON);
	HSEStartUpStatus=RCC_WaitForHSEStartUp();
	if(HSEStartUpStatus==SUCCESS){
		//����PLLʱ�� == �ⲿ���پ���ʱ��*9
		RCC_PLLConfig(RCC_PLLSource_HSE_Div1, RCC_PLLMul_9); 
		//����FLASHԤȡֵ
		//FLASH_PrefetchBufferCmd(FLASH_PrefetchBuffer_Enable);
		//����FLASH_Lacency��ʱ2����
		//FLASH_SetLatency(FLASH_Latency_2);

   		//����AHB(HCLK)ʱ��=SYSCLK
		RCC_HCLKConfig(RCC_SYSCLK_Div1);

    	//����APB2(PCLK2)��=AHBʱ��
		RCC_PCLK1Config(RCC_HCLK_Div2);

    	//����APB1(PCLK1)��=AHB 1/2ʱ��
		RCC_PCLK2Config(RCC_HCLK_Div1);

   		//����ADCʱ��=PCLK2 1/4
		RCC_ADCCLKConfig(RCC_PCLK2_Div4);



		//ʹ��PLL
		RCC_PLLCmd(ENABLE);

		//�ȴ�PLLʱ�Ӿ���
		while(RCC_GetFlagStatus(RCC_FLAG_PLLRDY)==RESET)
		{
		}
		//SYSCLK = PLL
		RCC_SYSCLKConfig(RCC_SYSCLKSource_PLLCLK);
		//���PLLʱ���Ƿ�ΪSYSCLK
		while(RCC_GetSYSCLKSource() != 0x08)
		{
		}
	}	 
	RCC_APB1PeriphClockCmd(RCC_APB1Periph_TIM2|RCC_APB1Periph_TIM3,ENABLE);//|RCC_APB1Periph_USART2
	RCC_APB2PeriphClockCmd(RCC_APB2Periph_SPI1|RCC_APB2Periph_USART1|RCC_APB2Periph_GPIOA|RCC_APB2Periph_GPIOB|
													RCC_APB2Periph_GPIOC|RCC_APB2Periph_GPIOD,ENABLE);
	GPIO_PinRemapConfig(GPIO_Remap_SWJ_JTAGDisable,DISABLE);//stop JATG
}


/***************
*irq config

*
************************/
void NVIC_Config(void) 
{ 
    NVIC_InitTypeDef NVIC_InitStructure; 				 
    NVIC_PriorityGroupConfig(NVIC_PriorityGroup_0); 	 //�������ȼ����飺��ռ���ȼ��ʹ����ȼ�
    NVIC_InitStructure.NVIC_IRQChannel=USART2_IRQChannel;          //ͨ�� ʹ�ܻ���ʧ��ָ����IRQ ͨ��
    NVIC_InitStructure.NVIC_IRQChannelPreemptionPriority=0;// �ò��������˳�ԱNVIC_IRQChannel  �е���ռ���ȼ�
    NVIC_InitStructure.NVIC_IRQChannelSubPriority=0; //   �ò��������˳�ԱNVIC_IRQChannel  �еĴ����ȼ�
    NVIC_InitStructure.NVIC_IRQChannelCmd=ENABLE; 		 //ͨ������
    NVIC_Init(&NVIC_InitStructure); 
} 

